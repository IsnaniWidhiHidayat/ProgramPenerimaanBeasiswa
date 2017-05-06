using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesAI
{
    class MakeTree
    {
        public static string Tree(int coloumAndGain, int AtributMahasiswa) // Membuat Tree 
        {
            int[] YesNo = new int[2];    

            YesNo = DatabaseScript.treeScript(coloumAndGain, AtributMahasiswa);

                if(YesNo[0] > 0 && YesNo[1]==0){

                    DatabaseScript.logForm.addText("Ya => " + YesNo[0] + "\n" + "No =>" + YesNo[1] + "\nResult is Ya", Color.LawnGreen);
                    return "Ya";                   
                }
                else if(YesNo[0]==0 && YesNo[1]>0){

                    DatabaseScript.logForm.addText("Ya => " + YesNo[0] + "\n" + "No =>" + YesNo[1] + "\nResult is No", Color.Red);
                    return "Tidak";
                   
                }
                else if (YesNo[0] > 0 && YesNo[1] > 0 && coloumAndGain == Rumus.coloumAndGain.Count - 1 )
                {
                    DatabaseScript.logForm.addText("Ya => " + YesNo[0] + "\n" + "No =>" + YesNo[1] + "\nData Ambigu", Color.MediumPurple);
                    return "-"; // Data Ambigu
                
                }else if (YesNo[0]>0 && YesNo[1]>0){
                    DatabaseScript.logForm.addText("Ya => " + YesNo[0] + "\n" + "No =>" + YesNo[1] + "\n", Color.MediumSpringGreen);
                    return Tree(coloumAndGain + 1, AtributMahasiswa + 1);
                
                }else{

                    DatabaseScript.logForm.addText("Ya => " + YesNo[0] + "\n" + "No =>" + YesNo[1] + "\nData is not Found", Color.Yellow);
                    return "-"; // Data belum tercukupi          
                }
         
        }
    }
}
