using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleTest
{
    class Program
    {
      
        static void Main(string[] args)
        {
            double pi_wy, sum_wy = 0.0, seri_t_wy, para_t_wy;
            Stopwatch stopwatch = new Stopwatch();
            Pi_Thread ParallelOne = new Pi_Thread(1);
            ThreadStart StartOne = new ThreadStart(ParallelOne.Pi_paral);
            Thread newThreadOne = new Thread(StartOne);

            Pi_Thread threadTwo = new Pi_Thread(2);
            ThreadStart StartTwo = new ThreadStart(threadTwo.Pi_paral);
            Thread newThreadTwo = new Thread(StartTwo);

            stopwatch.Start();
            newThreadOne.Start();
            newThreadTwo.Start();
            newThreadOne.Join();
            newThreadTwo.Join();
            stopwatch.Stop();

            TimeSpan wy_timeSpan_paral = stopwatch.Elapsed;
            sum_wy = ParallelOne.sum + threadTwo.sum;
            pi_wy = ParallelOne.step * sum_wy;
            para_t_wy = wy_timeSpan_paral.TotalMilliseconds;
            Console.WriteLine("并行结果: " + pi_wy);
            Console.WriteLine("并行时间: " + para_t_wy);


            Pi_Thread SerilThread = new Pi_Thread(1);
            stopwatch.Start();
            SerilThread.Pi_seril();
            stopwatch.Stop();


            TimeSpan wy_timeSpan_seril = stopwatch.Elapsed;
            pi_wy = SerilThread.step * SerilThread.sum;
            seri_t_wy = wy_timeSpan_seril.TotalMilliseconds - para_t_wy;
            Console.WriteLine("并行结果: " + pi_wy);
            Console.WriteLine("并行时间: " + seri_t_wy);
            Console.WriteLine("加速比: " + seri_t_wy / para_t_wy);
            Console.Read();



        }
    }

    class Pi_Thread
    {
        int start_wy;
        int num_steps_wy = 100000000;
        public double step, x, sum = 0.0;
        public Pi_Thread(int start)
        {
            this.start_wy = start;
        }

        public void Pi_paral()
        {
            int i;
            step = 1.0 / (double)num_steps_wy;
            for (i = start_wy; i <= num_steps_wy; i += 2)
            {
                x = (i + 0.5) * step;
                sum = sum + 4.0 / (1.0 + x * x);
            }


        }


        public void Pi_seril()
        {
            int i;
            step = 1.0 / (double)num_steps_wy;
            for (i = 1; i <= num_steps_wy; i++)
            {
                x = (i + 0.5) * step;
                sum = sum + 4.0 / (1.0 + x * x);
            }
        }
    }

}
