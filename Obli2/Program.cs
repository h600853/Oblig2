﻿using SpaceSim;

namespace Oblig2
{
    public class Program
    {
        public static void Main()
        {
            Star sun = new Star("Sun", 0, 0, 696.340, 26, "yellow");
            //name, orbitalRadius, orbitalPeriod, objectRadius, rotationalPeriod, objectColour.
            //orbital radius in million km 
            //object radius in km 
            Planet mercury = new Planet("Mercury", 57.91, 87.97, 2.440, 59, "DarkGray");
            Planet venus = new Planet("Venus", 108.2, 224.7, 6.052, -243, "Yellow");
            Planet earth = new Planet("Earth", 149.6, 365.2, 6.371, 24, "Blue");
            Planet mars = new Planet("Mars", 228, 687, 3.390, 25, "Red");
            Planet jupiter = new Planet("Jupiter", 778.5,  4.331, 69.911, 10, "Orange");
            Planet saturn = new Planet("Saturn", 1400000000, 10747.0, 58.232, 11, "Yellow");
            Planet uranus = new Planet("Uranus", 2870000000, 30.589, 25.362, -17, "LightBlue");
            Planet neptune = new Planet("Neptune", 4500000000, 59800.0, 24.622, 16, "DarkBlue");

            DwarfPlanet ceres = new DwarfPlanet("Ceres", 413.8, 4.6, 487.3, 9.07, "Gray");
            DwarfPlanet pluto = new DwarfPlanet("Pluto", 2376.6, 90560.0, 1188.3, -6.39, "Brown");
            DwarfPlanet haumea = new DwarfPlanet("Haumea", 1632.0, 103287.0, 816.0, 3.9, "Brown");
            DwarfPlanet makemake = new DwarfPlanet("Makemake", 1434.0, 112897.0, 715.0, 22.5, "Orange");
            DwarfPlanet eris = new DwarfPlanet("Eris", 2326.0, 203830.0, 1163.0, -25.9, "Brown");

            Asteroid vesta = new Asteroid("Vesta", 525.4, 3.63, 262.7, 0, "Gray");
            Asteroid pallas = new Asteroid("Pallas", 512.0, 4.62, 512.0, 0, "Brown");
            Asteroid hygiea = new Asteroid("Hygiea", 431.0, 5.6, 215.7, 0,  "Gray");
            Asteroid interamnia = new Asteroid("Interamnia", 350.0, 5.57, 161.0, 0, "Gray");


            Moon moon = new Moon("Moon", 384.4, 27.3, 1.737, 27.3, "Gray");

            //Mars moons 
            Moon phobos = new Moon("Phobos", 9377, 0.31891023, 11.27, 0.31891023, "grey");
            Moon deimos = new Moon("Deimos", 23463.2, 1.263, 6.2, 1.263, "red");

            //Venus Moons 
            Moon europa = new Moon("Europa", 671100, 3.551181, 1560.8, 3.551181, "white");
            Moon io = new Moon("Io", 421700, 1.769138, 1821.6, 1.769138, "yellow");
            Moon ganymedes = new Moon("Ganymedes", 1070400, 7.15455296, 2634.1, 7.15455296, "grey");

            //Saturn Moons
            Moon titan = new Moon("Titan", 1221870, 15.945, 5150, 15.945, "orange");
            Moon enceladus = new Moon("Enceladus", 238020, 1.370218, 504.2, 1.370218, "white");
            Moon mimas = new Moon("Mimas", 185539, 0.942422, 396.4, 0.942422, "grey");

            //Uranus Moons
            Moon miranda = new Moon("Miranda", 129390, 1.413479, 235.8, 1.413479, "grey");
            Moon titania = new Moon("Titania", 435910, 8.706234, 1577.8, 8.706234, "yellow");
            Moon oberon = new Moon("Oberon", 582600, 13.463239, 1522.8, 13.463239, "orange");

            //Neptune Moons
            Moon triton = new Moon("Triton", 354759, 5.876854, 1353.4, -5.876854, "pink");



            Console.WriteLine("Enter a time. (number of days since time 0)");
            String input = Console.ReadLine();
            int time = int.Parse(input);
            Console.WriteLine("Enter the name of a Planet: ");
            String planet = Console.ReadLine().ToLower();

            switch(planet)
            {
                case "mercury":
                {
                        Console.WriteLine("You entered Mercury: ");
                        mercury.CalculatePosition(time);
                        mercury.Draw();
                break;
                }
                case "venus":
                    {
                        Console.WriteLine("You entered Venus: ");
                        venus.CalculatePosition(time);
                        venus.Draw();   

                        Console.WriteLine("Moons: ");
                        europa.CalculatePosition(time); 
                        europa.Draw();
                        io.CalculatePosition(time); 
                        io.Draw();  
                        ganymedes.CalculatePosition(time);  
                        ganymedes.Draw();
                    }
                        break;
                case "earth":
                    {
                        Console.WriteLine("You entered Earth: ");
                          earth.CalculatePosition(time);
                        earth.Draw();
                      
                        Console.WriteLine("Moons: ");
                        moon.CalculatePosition(time);   
                        moon.Draw();
                        
                    }
                        break;
                case "mars":
                    {
                        Console.WriteLine("You entered Mars: ");    
                            mars.CalculatePosition(time);   
                            mars.Draw();    
                            
                    }
                        break;
                case "jupiter":
                    {
                        Console.WriteLine("You entered Jupiter: ");
                         jupiter.CalculatePosition(time);
                         jupiter.Draw();    
                        
                    }
                        break;
                case "saturn":
                    {
                        Console.WriteLine("You entered Saturn: ");
                        saturn.CalculatePosition(time); 
                        saturn.Draw();  

                        Console.WriteLine("Moons: ");
                        titan.CalculatePosition(time);  
                        titan.Draw(); 
                        enceladus.CalculatePosition(time);  
                        enceladus.Draw();
                        mimas.CalculatePosition(time);  
                        mimas.Draw();
                    }
                        break;
                case "uranus":
                    {
                        Console.WriteLine("You entered Uranus: ");
                        uranus.CalculatePosition(time); 
                       uranus.Draw();   

                        Console.WriteLine("Moons: ");
                        miranda.CalculatePosition(time);    
                        miranda.Draw();
                        titania.CalculatePosition(time);    
                        titania.Draw();
                        oberon.CalculatePosition(time); 
                        oberon.Draw();  
                    }
                        break;
                case "neptune":
                    {
                      Console.WriteLine("You entered Neptune: ");  
                        neptune.CalculatePosition(time);    
                        neptune.Draw();

                        Console.WriteLine("Moons: ");
                        triton.CalculatePosition(time); 
                        triton.Draw();
                    }
                        break;
                default:
                    {
                       sun.Draw();
                        mercury.CalculatePosition(time);
                        mercury.Draw();
                        venus.CalculatePosition(time);
                        venus.Draw();
                        europa.CalculatePosition(time);
                        europa.Draw();
                        io.CalculatePosition(time);
                        io.Draw();
                        ganymedes.CalculatePosition(time);
                        ganymedes.Draw();
                        earth.CalculatePosition(time);
                        earth.Draw();
                        moon.CalculatePosition(time);
                        moon.Draw();
                        mars.CalculatePosition(time);
                        mars.Draw();
                        jupiter.CalculatePosition(time);
                        jupiter.Draw();
                        saturn.CalculatePosition(time);
                        saturn.Draw();
                        titan.CalculatePosition(time);
                        titan.Draw();
                        enceladus.CalculatePosition(time);
                        enceladus.Draw();
                        mimas.CalculatePosition(time);
                        mimas.Draw();
                        uranus.CalculatePosition(time);
                        uranus.Draw();
                        miranda.CalculatePosition(time);
                        miranda.Draw();
                        titania.CalculatePosition(time);
                        titania.Draw();
                        oberon.CalculatePosition(time);
                        oberon.Draw();
                        neptune.CalculatePosition(time);
                        neptune.Draw();
                        triton.CalculatePosition(time);
                        triton.Draw();
                    }
                    break;

            }



        }
    }
}
