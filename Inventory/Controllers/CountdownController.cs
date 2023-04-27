using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Timers;

namespace Inventory.Controllers
{
    public class CountdownController : ApiController
    {
        public CountdownController()
        {
            countdownTimer = new Timer(1000); // timer interval is 1 second
           
        }       

        private Timer countdownTimer;
        private int countdownDuration = 60; // duration in seconds

        [HttpGet]
        public IHttpActionResult Start()
        {            
            countdownTimer.Start();
            var obj = new InventoryEntities();
            var items = obj.tblItems.ToList();
            var response = new MyResponse { MyItemList = items, CountDown = countdownDuration , StartTime=DateTime.Now.ToString()};
            return Ok(response);
        }

    }
}
