﻿namespace Patterns
{
    public class Sun
    {
        //TODO: Ну ты поняла.
        private static Sun instance;

        protected Sun() { }

        public static Sun Instance()
        {
            if (instance == null)
            {
                instance = new Sun();
            }

            return instance;
        }

        public int FlyTo()
        {
            return 0;
        }
    }
}