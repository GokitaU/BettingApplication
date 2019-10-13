﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Aplikacija_za_kladenje.Models;
using System.Globalization;
using Aplikacija_za_kladenje.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Aplikacija_za_kladenje.Controllers
{
    [Authorize]
    public class UserBetsController : Controller
    {
        private readonly Aplikacija_za_kladenjeContext _context;

        public UserBetsController(Aplikacija_za_kladenjeContext context)
        {
            _context = context;
        }

        // GET: UserBets
        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            var userBet = _context.UserBets.Where(x => x.User.Id == userId).Include(t => t.Matches).ToListAsync();
            TempData["Username"] = user.UserName;
            return View(await userBet);
        }

        [HttpGet]
        public async Task<IActionResult> UserBet()
        {
            
            return View(await _context.BetSlip.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> UserBet(string stake, string TotalOdd, string submit)
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
            var wallet = _context.Wallet.Where(x => x.Userid == user.Id).FirstOrDefault();
            TempData["betmsg"] = null;
            
            if (submit == "Remove")
            {
                foreach (BetSlip item in _context.BetSlip.Where(b => b.User.Id == userId))
                {
                    _context.Remove(item);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            var betStake = decimal.Parse(stake, new NumberFormatInfo() { NumberDecimalSeparator = "." });
            bool tempTopStatus = false;
            int counter = 0;
            int counterOdd = 0;
            foreach (BetSlip item in _context.BetSlip.Where(b => b.User.Id == userId))
            {
                if (item.TopMatch == true)
                {
                    tempTopStatus = true;
                }
                if (item.Odd > 1.10m)
                {
                    counterOdd++;
                }
                counter++;
            }
            if(counter == 0)
            {
                TempData["betmsg"] = "0 pair on ticket";
                return RedirectToAction("Index", "Home");
            }
            if ((counterOdd <= 5 || counter <= 5) && tempTopStatus == true)
            {
                TempData["betmsg"] = "The transaction is not successful";
                return RedirectToAction("Index", "Home");
            }
            UserTransactions transaction = new UserTransactions();
            List<UserTransactions> listTransactions = new List<UserTransactions>();
            if (((wallet.Saldo - betStake) >= 0 && betStake >= 1))
            {
                wallet.Saldo -= betStake;
                transaction.UserId = wallet.Userid;
                transaction.Payment = stake;
                transaction.Transactions = "Uplata listica u iznosu od " + stake + " kn " + " " + DateTime.Now.ToString();
                TempData["betmsg"]= "The transaction is successful";
                listTransactions.Add(transaction);
                wallet.Transactions = listTransactions;
                await _context.SaveChangesAsync();
                UserBets userBet = new UserBets();
                decimal totOdd = decimal.Parse(TotalOdd);
                userBet.TimeStamp = DateTime.Now;
                userBet.BetAmount = betStake;
                userBet.CashOut = (betStake / 100 * 95) * totOdd;
                userBet.TotalOdd = totOdd;
                userBet.User = user;
                List<UserBetMatches> listBetMatches = new List<UserBetMatches>();

                foreach (BetSlip item in _context.BetSlip.Where(b => b.User.Id == userId))
                {
                    UserBetMatches temp = new UserBetMatches();
                    //var football = _context.Matches.Include(h=>h.HomeTeam).Include(a=>a.AwayTeam).SingleOrDefault(q => q.Id == item.MatchId);
                    temp.MatchId = item.MatchId;
                    temp.HomeTeam = item.HomeTeam;
                    temp.AwayTeam = item.AwayTeam;
                    temp.Odd = item.Odd;
                    temp.Type = item.Type;
                    temp.TopMatch = item.TopMatch;
                    listBetMatches.Add(temp);
                }
                userBet.Matches = listBetMatches;
                _context.UserBets.Add(userBet);
                await _context.UserBets.AddAsync(userBet);
                _context.SaveChanges();
            }
            else
            {
                TempData["betmsg"] = "The transaction is not successful";
                return RedirectToAction("Index","Home");
            }
           
            return RedirectToAction("Index");
        }


        // GET: UserBets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userBets = await _context.UserBets.Include(b => b.Matches)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userBets == null)
            {
                return NotFound();
            }

            return View(userBets);
        }


        // GET: UserBets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userBets = await _context.UserBets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userBets == null)
            {
                return NotFound();
            }

            return View(userBets);
        }

        // POST: UserBets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userBets = await _context.UserBets.FindAsync(id);
            _context.UserBets.Remove(userBets);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserBetsExists(int id)
        {
            return _context.UserBets.Any(e => e.Id == id);
        }
    }
}
