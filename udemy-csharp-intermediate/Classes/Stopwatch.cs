using System;

namespace udemy_csharp_intermediate.Classes
{
    public class Stopwatch
    {
        public TimeSpan Duration { get; private set; }
        private DateTime _startTime;
        private bool _hasStarted;

        public void Start()
        {
            if (_hasStarted)
                throw new InvalidOperationException("The stopwatch has already been started before.");

            _startTime = DateTime.Now;
            _hasStarted = true;
        }

        public void Stop()
        {
            Duration = DateTime.Now - _startTime;
            _hasStarted = false;
        }
    }
}