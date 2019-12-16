using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LifeCounterBT.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region Properties

        public int UserLife { get; set; }
        public int OpponentLife { get; set; }

        #endregion

        #region Private fields

        #endregion

        #region PropertyChanged
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        #endregion
        
        #region Init


        public MainPageViewModel()
        {
            UserLife = 20;
            OpponentLife = 20;
        }

        #endregion

        #region Commands

        #region DecreaseUserLifeCommand

        private MvxCommand _DecreaseUserLifeCommand;
        public MvxCommand DecreaseUserLifeCommand
        {
            get 
            {
                if (_DecreaseUserLifeCommand == null)
                    _DecreaseUserLifeCommand = new MvxCommand(DecreaseUserLifeCommandCall);
                return _DecreaseUserLifeCommand; 
            }
        }

        private void DecreaseUserLifeCommandCall()
        {
            UserLife--;
        }

        #endregion

        #region IncreaseUserLifeCommand

        private MvxCommand _IncreaseUserLifeCommand;


        public MvxCommand IncreaseUserLifeCommand
        {
            get
            {
                if (_IncreaseUserLifeCommand == null)
                    _IncreaseUserLifeCommand = new MvxCommand(IncreaseUserLifeCommandCall);
                return _IncreaseUserLifeCommand;
            }
        }

        private void IncreaseUserLifeCommandCall()
        {
            UserLife++;
        }

        #endregion

        #region DecreaseOpponentLifeCommand

        private MvxCommand _DecreaseOpponentLifeCommand;
        public MvxCommand DecreaseOpponentLifeCommand
        {
            get
            {
                if (_DecreaseOpponentLifeCommand == null)
                    _DecreaseOpponentLifeCommand = new MvxCommand(DecreaseOpponentLifeCommandCall);
                return _DecreaseOpponentLifeCommand;
            }
        }

        private void DecreaseOpponentLifeCommandCall()
        {
            OpponentLife--;
        }

        #endregion

        #region IncreaseOpponentLifeCommand

        private MvxCommand _IncreaseOpponentLifeCommand;

        public MvxCommand IncreaseOpponentLifeCommand
        {
            get
            {
                if (_IncreaseOpponentLifeCommand == null)
                    _IncreaseOpponentLifeCommand = new MvxCommand(IncreaseOpponentLifeCommandCall);
                return _IncreaseOpponentLifeCommand;
            }
        }

        private void IncreaseOpponentLifeCommandCall()
        {
            OpponentLife++;
        }

        #endregion

        #endregion
    }
}
