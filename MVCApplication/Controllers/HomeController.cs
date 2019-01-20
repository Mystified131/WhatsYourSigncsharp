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
                    resultViewModel.Imageplace = "/images/Aquarius.png";
                    resultViewModel.Desc = "Aquarius seem a bit of an odd-person out. They tend to quietly go about accomplishing their goals, often in unconventional ways. They are both eccentric and humane. They can tend towards laziness if they lose their sense of motivation.";
                    resultViewModel.Dates = "January 20- February 18";

                    return View(resultViewModel);

            }


            if ((resultViewModel.Bmonth == 2 & resultViewModel.Bday >= 20) || (resultViewModel.Bmonth == 3 & resultViewModel.Bday < 21))
                    {

               
            
                    resultViewModel.Sign = "Pisces";
                    resultViewModel.Englishtrans = "The Fish";
                    resultViewModel.Imageplace = "/images/Pisces.png";
                    resultViewModel.Desc = "Pisces are dreamers and mystics. They are often quiet, so it is hard to tell, but they have vivid internal lives. They are honest, compassionate and trustworthy. They can also be gullible and easily taken advantage of. Their determination helps them to succeed when it comes to goals.";
                    resultViewModel.Dates = "February 19- March 20";

                    return View(resultViewModel);

                }

                 
            if ((resultViewModel.Bmonth == 3 & resultViewModel.Bday >= 21) || (resultViewModel.Bmonth == 4 & resultViewModel.Bday < 21))
                        {

                          

                    resultViewModel.Sign = "Aries";
                    resultViewModel.Englishtrans = "The Ram";
                    resultViewModel.Imageplace = "/images/Aries.png";
                    resultViewModel.Desc = "Aries tend to love challenges. They are full of energy and zeal. They are both curious and driven, love to compete, and have a strong sense of justice. Aries are natural leaders.";
                    resultViewModel.Dates = "March 21- April 19";

                    return View(resultViewModel);

                }

                     
            if ((resultViewModel.Bmonth == 4 & resultViewModel.Bday >= 21) || (resultViewModel.Bmonth == 5 & resultViewModel.Bday < 22))
                            {

                  

                    resultViewModel.Sign = "Taurus";
                    resultViewModel.Englishtrans = "The Bull";
                    resultViewModel.Imageplace = "/images/Taurus.png";
                    resultViewModel.Desc = "Taurus are reliable, dedicated, committed people. They value security and stability. They bring order to the world. They can also be somewhat stubborn, disliking change.";
                    resultViewModel.Dates = "April 20- May 20";

                    return View(resultViewModel);

                }

                         
            if ((resultViewModel.Bmonth == 5 & resultViewModel.Bday >= 22) || (resultViewModel.Bmonth == 6 & resultViewModel.Bday < 22))
                                {

                    

                    resultViewModel.Sign = "Gemini";
                    resultViewModel.Englishtrans = "The Twins";
                    resultViewModel.Imageplace = "/images/Gemini.png";
                    resultViewModel.Desc = "Gemini love to socialize and to spend time with people. They like to communicate ideas and to share feelings. They enjoy what some might call idle chatter. Their love of small talk may make them seem nervous to some.";
                    resultViewModel.Dates = "May 21- June 20";

                    return View(resultViewModel);
                }

                           
            if ((resultViewModel.Bmonth == 6 & resultViewModel.Bday >= 22) || (resultViewModel.Bmonth == 7 & resultViewModel.Bday < 23))
                                    {

                                      

                    resultViewModel.Sign = "Cancer";
                    resultViewModel.Englishtrans = "The Crab";
                    resultViewModel.Imageplace = "/images/Cancer.png";
                    resultViewModel.Desc = "Cancers need to be needed, they need to feel loved. They have a strong sense of home and safety. They area also good at creating home-like environments for others.";
                    resultViewModel.Dates = "June 21- July 22";

                    return View(resultViewModel);

                }

                                 
            if ((resultViewModel.Bmonth == 7 & resultViewModel.Bday >= 23) || (resultViewModel.Bmonth == 8 & resultViewModel.Bday < 23))
                                        {

                                 

                    resultViewModel.Sign = "Leo";
                    resultViewModel.Englishtrans = "The Lion";
                    resultViewModel.Imageplace = "/images/Leo.png";
                    resultViewModel.Desc = "Leos have a regal bearing. They bring light and love to others. Their friends and followers adore them. They are used to being the center of attention. They are often happy and pleasing to be around.";
                    resultViewModel.Dates = "July 23- August 22";

                    return View(resultViewModel);

                }

                                    
            if ((resultViewModel.Bmonth == 8 & resultViewModel.Bday >= 23) || (resultViewModel.Bmonth == 9 & resultViewModel.Bday < 24))
                                            {

                                          

                    resultViewModel.Sign = "Virgo";
                    resultViewModel.Englishtrans = "The Maiden";
                    resultViewModel.Imageplace = "/images/Virgo.png";
                    resultViewModel.Desc = "Virgo are capable, organized, and analytical. They are curious people and good storytellers. They have gifts for research, memory and intuition. They are great collaborators, in spite of their tendency to occasionally seem critical.";
                    resultViewModel.Dates = "August 23- September 22";

                    return View(resultViewModel);

                }

                                         
            if ((resultViewModel.Bmonth == 9 & resultViewModel.Bday >= 24) || (resultViewModel.Bmonth == 10 & resultViewModel.Bday < 24))
                                                {

                           
                    resultViewModel.Sign = "Libra";
                    resultViewModel.Englishtrans = "The Scales";
                    resultViewModel.Imageplace = "/images/Libra.png";
                    resultViewModel.Desc = "A Libra desires justice, and is satisfied only when the scales are balanced. Sometimes they will go to extremes to pursue this goal, which can be unsafe. They are great defenders of the innocent and downtrodden. They love a good debate, in spite of having an introverted side.";
                    resultViewModel.Dates = "September 23- October 22";

                    return View(resultViewModel);

                }

                                           
            if ((resultViewModel.Bmonth == 10 & resultViewModel.Bday >= 24) || (resultViewModel.Bmonth == 11 & resultViewModel.Bday < 23))
                                                    {
                    

                    resultViewModel.Sign = "Scorpio";
                    resultViewModel.Englishtrans = "The Scorpion";
                    resultViewModel.Imageplace = "/images/Scorpio.png";
                    resultViewModel.Desc = "Scorpio are bold, intense and often misunderstood. They have great abilties to complete massive projects, and are quite impassioned beneath their cool exteriors. They can surmount almost any obstacle with their unshakable focus. Sometimes they are mistrusted due to seeming secretive during calculations.";
                    resultViewModel.Dates = "October 23- November 21";

                    return View(resultViewModel);

                }

                                                
            if ((resultViewModel.Bmonth == 11 & resultViewModel.Bday >= 23) || (resultViewModel.Bmonth == 12 & resultViewModel.Bday < 21))
                                                        {

                                                           

                    resultViewModel.Sign = "Saggitarius";
                    resultViewModel.Englishtrans = "The Archer";
                    resultViewModel.Imageplace = "/images/Saggitarius.png";
                    resultViewModel.Desc = "Saggitarius are wandering philosophers. They can have great focus, but also tend to move about, gathering thoughts and information. They can tend to go in too many directions for their own good. They are often hasty, lacking patience, and make good, if not committed, friends.";
                    resultViewModel.Dates = "November 22- December 21";

                    return View(resultViewModel);

                }

                                                    
            if ((resultViewModel.Bmonth == 12 & resultViewModel.Bday >= 21) || (resultViewModel.Bmonth == 1 & resultViewModel.Bday < 21))
                                                            {

                                                              

                    resultViewModel.Sign = "Capricorn";
                    resultViewModel.Englishtrans = "The Sea-Goat";
                    resultViewModel.Imageplace = "/images/Capricorn.png";
                    resultViewModel.Desc = "Capricorn enjoy applying their intellect to problems. They like stability. They have a sharp intuition, though they may seem secretive at times. They are responsible people, but can have trouble sharing their burdens with others, being inexpert at communicating.";
                    resultViewModel.Dates = "December 22- January 19";

                    return View(resultViewModel);

                }



                return Redirect("/Home/Error");



            }


            return Redirect("/Home/Error");

        }
                         
                                                }


                                            }

                                    

                              

                                
                                         
                                            

                                     
