using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tutorial2
    {
        private int TutorialID;
        private string TutorialName;

        public void SetTutorial(int pID, String pName)
        {
            TutorialID = pID;
            TutorialName = pName;
            
        }
        public String GetTutorial()
        {
            return TutorialName;
        }


        
    }
}
