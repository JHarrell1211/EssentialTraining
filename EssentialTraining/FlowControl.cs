using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class FlowControl
    {
        public string PrimaryOrSecondaryCompound(string color)
        {
            var result = "";
            if(color.ToLower() == "red" || color.ToLower() == "blue" || color.ToLower() == "yellow")
            {
                result = "Primary";
            }
            else
            {
                result = "Secondary";
            }
            return result;
        }
        public string SecondaryOrPrimary(string color)
        {
            var result = "";

            switch (color.ToLower())
            {
                case "red":
                    result = "Primary";
                    break;

                case "blue":
                    result = "Primary";
                    break;

                default:
                    result = "Secondary";
                    break;
            }
            return result;
        }

        public string PrimaryOrSecondary(string color)
        {
            var result = "";

            if(color.ToLower() == "red")
            {
                result = "Primary";
            }
            else if(color.ToLower() == "blue")
            {
                result = "Primary";
            }
            else if(color.ToLower() == "yellow")
            {
                result = "Primary";
            }
            else
            {
                result = "Secondary";
            }
            return result;
        }

        public bool IsYourFavoriteColorYellow(string color)
        {
            return (color.ToLower() == "yellow");
        }

        public bool IsYourFavoriteColorRed(string color)
        {
            if (color.ToLower() == "red") return true;
            return false;
        }

        public bool IsYourFavoritColorGreen(string color)
        {
            return (color.ToLower() == "green") ? true : false;
        }

        public bool IsYourFavoriteColorBlue(string color)
        {
            if(color.ToLower() == "blue")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
