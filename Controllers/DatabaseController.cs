using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab20CoffeeShopDatabase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab20CoffeeShopDatabase.Controllers
{
    public class DatabaseController : Controller
    {
        public readonly CoffeeShopDbContext _context;
        List<User> registerstuff = new List<User>();

        public DatabaseController(CoffeeShopDbContext context)
        {
            _context = context;
            
        }

       

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(new User());
        }
        public IActionResult ListOfRegisteredUsers()
        {
            string myList = HttpContext.Session.GetString("ListOfPeople");
            List<User> registerstuff = JsonConvert.DeserializeObject<List<User>>(myList);
            return View();

        }
        public IActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveLoginInfo(User guy, string SaveLogin)
        {
            if (SaveLogin == "yes")
            {
                //add a cookie to the browser to save the user's payment information
                CookieOptions option = new CookieOptions();
                Response.Cookies.Append("UserLoginName", guy.UserName, option); //cant store entire object in cookie
                //include properties that you want to keep
                Response.Cookies.Append("UserLoginFund", guy.Password, option); //guy.Funds
                //Response.Cookies.Append("CreditCardNumber", credit.Number, option);
            }
            // return RedirectToAction("Index", guy);
            return RedirectToAction("Index", guy);

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Register(User heyThere)
        {

            if (ModelState.IsValid)
            {
                string registerLoginJSon = HttpContext.Session.GetString("LoggedIn");
                if (registerLoginJSon != null)
                {
                   registerstuff = JsonConvert.DeserializeObject<List<User>>(registerLoginJSon);
                }
                registerstuff.Add(heyThere);
                HttpContext.Session.SetString("LoggedIn", JsonConvert.SerializeObject(heyThere));
                HttpContext.Session.SetString("ListOfPeople", JsonConvert.SerializeObject(registerstuff));

                return RedirectToAction("Summary", heyThere); //makes validation work
            }
            else
            {
                return View(heyThere);
            }
        }

        public IActionResult Summary(User heyThere)
        {
            return View(heyThere);

        }

        public IActionResult MakeNewUser()
        {
            List<User> userGuy = _context.User.ToList();
            return View(userGuy);
        }

        public IActionResult Shop(Item item)
        {
            string user = HttpContext.Session.GetString("ListOfItems");
            List<Item> itemList = _context.Item.ToList();
            if (user != null)
            {
                itemList= JsonConvert.DeserializeObject<List<Item>>(user);
                itemList.Add(item);
                HttpContext.Session.SetString("ListOfItems", JsonConvert.SerializeObject(user));
                
                return RedirectToAction("Index", item);
            }
            else
            {
                return View(itemList);
            }
            
        }
     
        [HttpPost]
        public IActionResult MakeNewUser(User newUser)
        {
            if (ModelState.IsValid) //16.
            {
                _context.User.Add(newUser);  //17.
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


        
        public IActionResult BuyItem(int Id)
        {
            User guy = new User();//??
            Item found = _context.Item.Find(Id); //19. create object, include int Id
            if (found != null)
            {
                if (found.Price < guy.Funds)
                {
                    return RedirectToAction("Checkout");
                }
                else
                {
                    return View("ErrorPage");
                }
                ///context.Item.Add(found); //adding whole object
                //_context.SaveChanges();
                //return RedirectToAction("Summary");
            }
            
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult ErrorPage()
        {
            return View();
        }
    }
}