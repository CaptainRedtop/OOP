using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt_test_.Model
{
    internal class NumberOfApartments
    {
        View.ExceptionGui exGui = new View.ExceptionGui();
		private string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		internal void WriteNumberOfApartments(List<Apartment.Apartment> apartments)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(path + "\\" + "apartments.txt"))
                {
                    foreach (Apartment.Apartment apartment in apartments)
                    {
                        try
                        {
                            sw.WriteLine(apartment);
                        }
                        catch (Exception ex)
                        {
                            exGui.ExceptionMessage("", ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                exGui.ExceptionMessage("", ex);
            }
        }
        internal int[] ReadNumberOfApartments()
        {
            int[] apartments = new int[5];
            string line;
            int oneRoom = 0;
            int twoRoom = 0;
            int threeRoom = 0;
            int fourRoom = 0;
            int fiveRoom = 0;

            try
            {
                using (StreamReader reader = new StreamReader(path + "\\" + "apartments.txt")) 
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains("OneRoomApartment"))
                        {
                            oneRoom++;
                        }
                        else if (line.Contains("TwoRoomApartment"))
                        {
                            twoRoom++;
                        }
                        else if (line.Contains("ThreeRoomApartment"))
                        {
                            threeRoom++;
                        }
                        else if (line.Contains("FourRoomApartment"))
                        {
                            fourRoom++;
                        }
                        else
                        {
                            fiveRoom++;
                        }
                    }
                }
                apartments[0] = oneRoom;
                apartments[1] = twoRoom;
                apartments[2] = threeRoom;
                apartments[3] = fourRoom;
                apartments[4] = fiveRoom;
            }
            catch (Exception ex)
            {
                exGui.ExceptionMessage("", ex);
            }
            return apartments;
	    }

    }
}
