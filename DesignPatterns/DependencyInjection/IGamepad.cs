using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DependencyInjection
{
    public interface IGamepad
    {
        public void MoveUpHelp();
        public void MoveDownHelp();
        public void MoveLeftHelp();
        public void MoveRightHelp();
    }
}
