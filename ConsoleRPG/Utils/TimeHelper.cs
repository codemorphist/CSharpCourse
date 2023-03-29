using System;

namespace ConsoleRPG.Utils
{
    abstract class TimeHelper
    {
        protected DateTime CreatedAt;
        protected DateTime UpdatedAt;
        protected DateTime DeletedAt;
        protected bool IsDelete = false;
        protected const string format = "dddd, d/MM/yy, H:mm, K";

        public TimeHelper()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public void Deleted()
        {
            IsDelete = true;
            DeletedAt = DateTime.Now;
        }

        protected void Updated()
        {
            UpdatedAt = DateTime.Now;
        }

        protected bool CheckUpdate()
        {
            return !CreatedAt.Equals(UpdatedAt);
        }

        public string GetFormatCreatedAt()
        {
            return CreatedAt.ToString(format);
        }
    }
}
