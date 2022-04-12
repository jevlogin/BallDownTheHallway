using System.Collections.Generic;

namespace WORLDGAMEDEVELOPMENT
{
    internal class Controllers : IInitialization
    {
        #region Fields

        private readonly List<IInitialization> _initializeControllers;
        private readonly List<IExecute> _executeControllers;
        private readonly List<ILateExecute> _lateControllers;
        private readonly List<IFixedExecute> _fixedControllers;
        private readonly List<ICleanup> _cleanupControllers;

        #endregion


        #region ClassLifeCycles

        public Controllers()
        {
            _initializeControllers = new List<IInitialization>();
            _executeControllers = new List<IExecute>();
            _lateControllers = new List<ILateExecute>();
            _fixedControllers = new List<IFixedExecute>();
            _cleanupControllers = new List<ICleanup>();
        }

        #endregion

        public void Initialization()
        {
            throw new System.NotImplementedException();
        }
    }
}