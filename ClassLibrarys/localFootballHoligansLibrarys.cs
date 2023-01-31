using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarys
{
    public class LocalFootballHoligansLibrarys
    {


        public string Football(int pass, string mål) {

            string jubel = "";
            //So no matter how you type mål then it will always come out as MÅL
            mål = mål.ToLower();
            
            if (pass <= 0)
            {// if there is 0 passes
                jubel= "shh";
            } else if (pass>= 10)
            {//over 10 passes
                jubel = "*Highfive* Jubel";
            }
            else
            {
            while (pass > 0)
                { //a counter for passess
                    jubel = "Huh!" + jubel;
                    pass--;
                }

            } // the respond for "Mål"
            if (mål == "mål") {
                jubel = "Olé olé olé";
            }

            return jubel;
            


            
        }

        


    }
}
   

