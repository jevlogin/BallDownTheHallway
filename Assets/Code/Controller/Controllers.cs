using System.Collections.Generic;
using UnityEngine;

namespace WORLDGAMEDEVELOPMENT
{
    internal class Controllers : IInitialization, IExecute, ILateExecute, IFixedExecute, ICleanup
    {
        #region Fields

        private readonly List<IInitialization> _initializeControllers;
        private readonly List<IExecute> _executeControllers;
        private readonly List<ILateExecute> _lateControllers;
        private readonly List<IFixedExecute> _fixedControllers;
        private readonly List<ICleanup> _cleanupControllers;
        private List<GameObject> _gameObjects;


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


        #region Methods

        public Controllers Add(IController controller)
        {
            if (controller is IInitialization initialization)
            {
                _initializeControllers.Add(initialization);
            }
            if (controller is IFixedExecute fixedExecute)
            {
                _fixedControllers.Add(fixedExecute);
            }
            if (controller is IExecute execute)
            {
                _executeControllers.Add(execute);
            }
            if (controller is ICleanup cleanup)
            {
                _cleanupControllers.Add(cleanup);
            }
            if (controller is ILateExecute lateExecute)
            {
                _lateControllers.Add(lateExecute);
            }
            return this;
        }

        protected void AddGameObjects(GameObject gameObject)
        {
            if (_gameObjects == null)
            {
                _gameObjects = new List<GameObject>();
            }
            _gameObjects.Add(gameObject);
        }

        #endregion


        #region IInitialization

        public void Initialization()
        {
            for (int index = 0; index < _initializeControllers.Count; index++)
            {
                _initializeControllers[index].Initialization();
            }
        }

        #endregion


        #region ICleanup

        public void Cleanup()
        {
            for (int index = 0; index < _cleanupControllers.Count; index++)
            {
                _cleanupControllers[index].Cleanup();
            }
            if (_gameObjects != null)
            {
                foreach (GameObject cahedGameObject in _gameObjects)
                {
                    Object.Destroy(cahedGameObject);
                }
                _gameObjects.Clear();
            }
        }

        #endregion


        #region IExecute

        public void Execute(float deltaTime)
        {
            for (int index = 0; index < _executeControllers.Count; index++)
            {
                _executeControllers[index].Execute(deltaTime);
            }
        }

        #endregion


        #region iFixedExecute

        public void FixedExecute(float deltaTime)
        {
            for (int index = 0; index < _fixedControllers.Count; index++)
            {
                _fixedControllers[index].FixedExecute(deltaTime);
            }
        }

        #endregion


        #region ILateExecute

        public void LateExecute(float deltaTime)
        {
            for (int index = 0; index < _lateControllers.Count; index++)
            {
                _lateControllers[index].LateExecute(deltaTime);
            }
        }

        #endregion

    }
}