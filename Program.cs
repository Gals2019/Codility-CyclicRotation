using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int veces = 5;
            int[] A = {0};
          

            for (int i = 0; i < veces; i++)
            {
                
                int numGuardar = -1;
                int numSiguiente;
                for (int b = 0; b < A.Length; b++)
                {

                    if (A.Length>1)
                    {
                        if (b == 0)
                        {
                            numGuardar = A[b + 1];
                            A[b + 1] = A[b];

                        }
                        else
                        {

                            if ((b + 1) == A.Length)
                            {

                                A[0] = numGuardar;
                                break;
                            }
                            else
                            {
                                numSiguiente = A[b + 1];
                                A[b + 1] = numGuardar;
                                numGuardar = numSiguiente;
                            }

                        }
                    }
                    else
                    {
                        
                        break;
                    }
                }


            }


            return A;
        }
    }
}
