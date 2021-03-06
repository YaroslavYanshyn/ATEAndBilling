﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATEAndBilling.Interfaces;
using ATEAndBilling.Enums;

namespace ATEAndBilling.Args
{
    public class CallEventArgs : EventArgs, ICallingEventArgs
    {
        public int TelephoneNumber { get; private set; }
        public int TargetTelephoneNumber { get; private set; }
        public Guid Id { get; private set; }
        public CallEventArgs(int number, int target)
        {
            TelephoneNumber = number;
            TargetTelephoneNumber = target;
        }
        public CallEventArgs(int number, int target, Guid id)
        {
            TelephoneNumber = number;
            TargetTelephoneNumber = target;
            Id = id;
        }
    }
}
