using System.Threading.Tasks;

using static ConsoleRPG.Utils.InputOutput;

namespace ConsoleRPG.Utils
{
    internal class Animation
    {
        string[][] animation;
        bool stop = true;

        public void StopAnimarion() { stop = false; }
        
        public string[] GetFrame(int num)
        {
            string[] frame = new string[animation[num].Length];

            for(int i = 0; i < animation[0].Length; i++)
            {
                frame[i] = animation[num][i];
            }

            return frame;
        }

        public async void DrawAnimation(int delay = 100, int top = 0, int left = 0)
        {
            await Task.Run(async () =>
            {
                while (stop)
                {
                    for (int i = 0; i < animation.Length; i++)
                    {
                        PrintArrayByCords(GetFrame(i), top, left);
                        await Task.Delay(delay);
                    }
                }
            });
        }

        public Animation(string[][] animation)
        {
            this.animation = animation;
        }
    }
}
