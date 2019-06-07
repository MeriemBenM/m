using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Consensus.Models;
using Consensus.Api;

namespace Consensus.Controllers
{
    public class HomeController : Controller
    {
        private static CryptoCurrency blockchain = BlockchainController.blockchain; 


        public IActionResult Index()
        {
            List<Transaction> transactions = blockchain.GetTransactions();
            ViewBag.Transactions = transactions;

            List<Block> blocks = blockchain.GetBlocks();
            ViewBag.Blocks = blocks;

            return View();
        }
        public IActionResult Mine()
        {
            blockchain.Mine();
            return RedirectToAction("Index");
        }

        
        public IActionResult ConnectNode()
        {

            return View(blockchain.GetNodes());
        }
        [HttpPost]
        public IActionResult RegisterNodes(string nodes)
        {
            string[] node = nodes.Split(',');
            blockchain.RegisterNodes(node);
            return RedirectToAction("ConnectNode");
        }
        // will get all blocks and will show all blocks 
        public IActionResult ListBlock()
        {
            List<Block> blocks = blockchain.GetBlocks();
            ViewBag.Blocks = blocks;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
