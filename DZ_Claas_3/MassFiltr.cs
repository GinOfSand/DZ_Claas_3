using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Claas_3
{
    internal class MassFiltr
    {   
       public static int[] MF_mass(int [] mOriginal, int [] mFilter)
        {
            int[]mass = new int[mOriginal.Length];
            int  flag = 0;
            int  size = 0;
            for(int i = 0; i <mOriginal.Length; i++)
            {
                for(int j = 0; j < mFilter.Length; j++)
                {
                    if(mOriginal[i] == mFilter[j])
                    {   
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    mass[i] = mOriginal[i];
                    size++;
                }
                flag = 0;
            }
            int j1 = 0;
            int[] mass2 = new int[size];
            for(int i = 0; i < mass.Length; i++)
            {   
                
                    if (mass[i] != 0)
                    {
                        mass2[j1] = mass[i];
                        j1++;
                    }
                
            }
            return mass2;
        }
    }
}
