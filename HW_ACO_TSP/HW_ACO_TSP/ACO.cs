using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ACO_TSP
{
    class ACO
    {
        private Random imRand;

        public int nAnt;
        public double Alpha;
        public double Beta;
        public double[,] Initial_Pheromone;
        public double Decay;//0~1
        public double Pheromone_Evaporation;


        public double[,] Cost = new double[17, 17];
        public double Total_Cost;

        public int[,] Solution;
        public int[] Temp_Solution;
        public int[] Best_Solution;
        public double[,] Pheromone;
        public double[,] Desirability;


        public double Sum;
        public double[] P;
        public double[] Q;

        public double r;

        public double Best = 10000;
        public double[] Current_Best;

        public double[,] Delta_GB_Pheromone;

        public ACO()
        {
            imRand = new Random();
        }

        public void Array_Length()
        {

            Solution = new int[nAnt, 17];
            Temp_Solution = new int[17];

            Best_Solution = new int[17];

            Pheromone = new double[17, 17];
            Initial_Pheromone = new double[17, 17];
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    Pheromone[i, j] = 1;
                }
            }

            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    Initial_Pheromone[i, j] = Pheromone[i, j];
                }
            }

            Desirability = new double[17, 17];
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if(Desirability[i, j] !=0)
                    {
                        Desirability[i, j] = 1 / Cost[i, j];
                    }
                    else
                    {
                        Desirability[i, j] = 1 / (Cost[i, j] + 2);
                    }

                }
            }

            Delta_GB_Pheromone = new double[17, 17];

            P = new double[17];
            Q = new double[17];

            Current_Best = new double[nAnt];

        }

        public double Objective_function(int a)
        {
            Total_Cost = 0;

            for (int i = 0; i < 17 - 1; i++)
            {
                Total_Cost += Cost[Solution[a, i], Solution[a, i + 1]];
            }

            Total_Cost += Cost[Solution[a, 16], Solution[a, 1]];

            return Total_Cost;
        }


        public void Move_City(int a, int l)
        {
            for (int c = 0; c < 17; c++)
            {
                Temp_Solution[c] = Solution[a, c];
            }

            Sum = 0;

            for (int c = 0; c < 17; c++)
            {
                if (Array.IndexOf(Temp_Solution, c) == -1)
                {
                    Sum += Math.Pow(Pheromone[Solution[a, l - 1], c], Alpha) * Math.Pow(Desirability[Solution[a, l - 1], c], Beta);
                }
            }

            for (int c = 0; c < 17; c++)
            {
                if (Array.IndexOf(Temp_Solution, c) == -1)
                {
                    P[c] = Math.Pow(Pheromone[Solution[a, l - 1], c], Alpha) * Math.Pow(Desirability[Solution[a, l - 1], c], Beta) / Sum;
                }
            }

            int Count = 0;

            for (int c = 0; c < 17; c++)
            {
                if (Array.IndexOf(Temp_Solution, c) == -1)
                {
                    if (Count == 0)
                    {
                        Q[c] = P[c];
                    }
                    else
                    {
                        Q[c] = Q[c - 1] + P[c];
                    }
                    Count++;

                }
            }

            for (int c = 0; c < 17; c++)
            {
                if (Array.IndexOf(Temp_Solution, c) == -1)
                {
                    r = imRand.NextDouble();
                    if (Q[c] > r)
                    {
                        Solution[a, l] = c;
                        break;
                    }
                }
            }
        }

        public void Local_Pheromone_Update(int a, int l)
        {
            Pheromone[Solution[a, l - 1], Solution[a, l]] = (1 - Decay) * Pheromone[Solution[a, l - 1], Solution[a, l]] + Decay * Initial_Pheromone[l - 1, l];
        }

        public void Best_Update(int a)
        {
            if (Objective_function(a) < Best)
            {
                Best = Objective_function(a);
                for (int c = 0; c < 17; c++)
                {
                    Best_Solution[c] = Solution[a, c];
                }
            }
            Current_Best[a] = Best;
        }

        public void Global_Pheromone_Update(int a)
        {
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    Delta_GB_Pheromone[i, j] = 0;
                }
            }

            for (int c = 0; c < 17 - 1; c++)
            {
                Delta_GB_Pheromone[Best_Solution[c], Best_Solution[c + 1]] = 1 / Best;
            }

            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    Pheromone[i, j] = (1 - Pheromone_Evaporation) * Pheromone[i, j] + Pheromone_Evaporation * Delta_GB_Pheromone[i, j];
                }
            }
        }

        public void Run_ACO()
        {
            Array_Length();

            for(int a = 0; a < nAnt; a++)
            {
                Solution[a, 0] = imRand.Next(17);

                for(int l = 1; l < 17; l++)
                {
                    Move_City(a, l);
                    Local_Pheromone_Update(a, l);
                }

                Best_Update(a);
                if(imRand.NextDouble()<0.5)
                {
                    Global_Pheromone_Update(a);
                }

            }
                
        }


    }
}
