using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.ViewModels;

namespace MVCApplication.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel();

            return View(indexViewModel);
        }

        public IActionResult Error()
        {

            return View();
        }

        public IActionResult Result()
        {
            ResultViewModel resultViewModel = new ResultViewModel();

            resultViewModel.Error = "To search for your Zodiacal Sign, please return to the 'Input' page.";

            return View(resultViewModel);
        }

        [HttpPost]
        public IActionResult Result(ResultViewModel resultViewModel)

        {
            if (ModelState.IsValid)
            {
                

            if ((resultViewModel.Bmonth == 1 & resultViewModel.Bday >= 21) || (resultViewModel.Bmonth == 2 & resultViewModel.Bday < 20))
            {



                resultViewModel.Sign = "Aquarius";
                resultViewModel.Englishtrans = "The Water-Bearer";

                return View(resultViewModel);

            }


            if ((resultViewModel.Bmonth == 2 & resultViewModel.Bday >= 20) || (resultViewModel.Bmonth == 3 & resultViewModel.Bday < 21))
                    {

               
            
                    resultViewModel.Sign = "Pisces";
                    resultViewModel.Englishtrans = "The Fish";

                    return View(resultViewModel);

                }

                 
            if ((resultViewModel.Bmonth == 3 & resultViewModel.Bday >= 21) || (resultViewModel.Bmonth == 4 & resultViewModel.Bday < 21))
                        {

                          

                    resultViewModel.Sign = "Aries";
                    resultViewModel.Englishtrans = "The Ram";

                    return View(resultViewModel);

                }

                     
            if ((resultViewModel.Bmonth == 4 & resultViewModel.Bday >= 21) || (resultViewModel.Bmonth == 5 & resultViewModel.Bday < 22))
                            {

                  

                    resultViewModel.Sign = "Taurus";
                    resultViewModel.Englishtrans = "The Bull";

                    return View(resultViewModel);

                }

                         
            if ((resultViewModel.Bmonth == 5 & resultViewModel.Bday >= 22) || (resultViewModel.Bmonth == 6 & resultViewModel.Bday < 22))
                                {

                    

                    resultViewModel.Sign = "Gemini";
                    resultViewModel.Englishtrans = "The Twins";

                    return View(resultViewModel);
                }

                           
            if ((resultViewModel.Bmonth == 6 & resultViewModel.Bday >= 22) || (resultViewModel.Bmonth == 7 & resultViewModel.Bday < 23))
                                    {

                                      

                    resultViewModel.Sign = "Cancer";
                    resultViewModel.Englishtrans = "The Crab";

                    return View(resultViewModel);

                }

                                 
            if ((resultViewModel.Bmonth == 7 & resultViewModel.Bday >= 23) || (resultViewModel.Bmonth == 8 & resultViewModel.Bday < 23))
                                        {

                                 

                    resultViewModel.Sign = "Leo";
                    resultViewModel.Englishtrans = "The Lion";

                    return View(resultViewModel);

                }

                                    
            if ((resultViewModel.Bmonth == 8 & resultViewModel.Bday >= 23) || (resultViewModel.Bmonth == 9 & resultViewModel.Bday < 24))
                                            {

                                          

                     resultViewModel.Sign = "Virgo";
                     resultViewModel.Englishtrans = "The Maiden";

                    return View(resultViewModel);

                }

                                         
            if ((resultViewModel.Bmonth == 9 & resultViewModel.Bday >= 24) || (resultViewModel.Bmonth == 10 & resultViewModel.Bday < 24))
                                                {

                           
                    resultViewModel.Sign = "Libra";
                    resultViewModel.Englishtrans = "The Scales";

                    return View(resultViewModel);

                }

                                           
            if ((resultViewModel.Bmonth == 10 & resultViewModel.Bday >= 24) || (resultViewModel.Bmonth == 11 & resultViewModel.Bday < 23))
                                                    {
                    

                    resultViewModel.Sign = "Scorpio";
                    resultViewModel.Englishtrans = "The Scorpion";

                    return View(resultViewModel);

                }

                                                
            if ((resultViewModel.Bmonth == 11 & resultViewModel.Bday >= 23) || (resultViewModel.Bmonth == 12 & resultViewModel.Bday < 21))
                                                        {

                                                           

                    resultViewModel.Sign = "Saggitarius";
                    resultViewModel.Englishtrans = "The Archer";

                    return View(resultViewModel);

                }

                                                    
            if ((resultViewModel.Bmonth == 12 & resultViewModel.Bday >= 21) || (resultViewModel.Bmonth == 1 & resultViewModel.Bday < 21))
                                                            {

                                                              

                    resultViewModel.Sign = "Capricorn";
                    resultViewModel.Englishtrans = "The Sea-Goat";

                    return View(resultViewModel);

                }



                return Redirect("/Home/Error");



            }


            return Redirect("/Home/Error");

        }
                         
                                                }


                                            }

                                    

                              

                                
                                         
                                            

                                     
