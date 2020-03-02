//Rupesh Kirmirwar 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuxoftTask2
{
    public class DeadPixels
    {
        public int CountGroups(char[][] monitor)
        {
            int dPGroups=0;//O(1)
            
            // check if the left top corner pixel is dead.
            if (monitor[0][0] == '1')//O(1)
                dPGroups++;//O(1)

            //check the first row and first column of pixels in monitor, startig from left,top
            for (int i=1; i<monitor.Length;i++)//O(n*(n-1))
            {
                //increase dead pixel group count if found any dead pixel and it is not following other dead pixel in first row
                if (monitor[0][i] == '1' && monitor[0][i - 1] == '0')
                    dPGroups++;

                //check if pixel is dead and it is not following other dead pixel in first column
                if (monitor[i][0] == '1' && monitor[i - 1][0] == '0')
                {
                    int nextInLine = 1;
                    bool skip = false;
                    //check if the dead pixel can be reached from another dead pixel from one row above, if yes then skip that pixel
                    while (nextInLine < monitor[0].Length && monitor[i][nextInLine] == '1')//O(n-1)
                    {
                        if (monitor[i - 1][nextInLine] == '1')
                        {
                            skip = true;
                            break;
                        }
                        nextInLine++;
                    }

                    //if pixel is not reachable increase the dead pixel group count
                    if (!skip)
                        dPGroups++;
                }
                   
            }

            //traverse through the monitor row by row starting from second row and second column 
            for (int i=1; i<monitor.Length;i++) //O((n-1)*(n-1)*(n-2))
            {
                for(int j=1; j<monitor[0].Length; j++) 
                {
                    //for each pixel, check if it is dead and not adjecent to previous dead pixel in same row or same column  
                    if (monitor[i][j]=='1' && monitor[i-1][j]=='0' && monitor[i][j-1]=='0')
                    {
                        int nextInLine=j + 1;
                        bool skip = false;
                        // for each dead pixel, check if it can be reached from another dead pixel from one row above, if yes then skip that pixel 
                        while (nextInLine< monitor[0].Length && monitor[i][nextInLine] =='1')
                        {
                            if (monitor[i - 1][nextInLine] == '1')
                            {
                                skip = true;
                                break;
                            }
                            nextInLine++;
                        }
                        //if pixel is not reachable increase the dead pixel group count
                        if (!skip)
                            dPGroups++;
                    }
                }
            }
            return dPGroups;//O(1)
        }
    }
}
// O(4+(n^2 -n)+(n-1)*(n-1)*(n-2))
//O(n^3)