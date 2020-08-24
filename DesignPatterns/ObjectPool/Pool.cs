using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObjectPool
{
    public static class Pool
    {
        private static List<Worker> _available = new List<Worker>();
        private static List<Worker> _inUse = new List<Worker>();

        public static Worker GetObject()
        {
            lock (_available)
            {
                if (_available.Count != 0)
                {
                    Worker po = _available[0];
                    _inUse.Add(po);
                    _available.RemoveAt(0);
                    return po;
                }
                else
                {
                    Worker po = new Worker();
                    _inUse.Add(po);
                    return po;
                }
            }
        }

        public static void ReleaseObject(Worker po)
        {
            CleanUp(po);

            lock (_available)
            {
                _available.Add(po);
                _inUse.Remove(po);
            }
        }

        private static void CleanUp(Worker po)
        {
            po.WorkData = null;
        }
    }
}
