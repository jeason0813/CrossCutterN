﻿/**
* Description: Switch factory
* Author: David Cui
*/

namespace CrossCutterN.Advice.Switch
{
    using System.Collections.Generic;

    internal static class SwitchFactory
    {
        public static IClassAdviceSwitchBuildUp InitializeClassAdviceSwitch(IList<bool> switchList)
        {
            return new ClassAdviceSwitch(switchList);
        }

        public static IClassAdviceSwitchOperation InitializeClassAdviceSwitchOperation(
            SequenceGenerator sequenceGenerator, IReadOnlyDictionary<string, SwitchOperationStatus> aspectOperations)
        {
            return new ClassAdviceSwitchOperation(sequenceGenerator, aspectOperations);
        }

        public static SwitchOperationStatus InitializeSwitchOperationStatus(SequenceGenerator sequenceGenerator, SwitchOperationStatus operation)
        {
            return new SwitchOperationStatus(sequenceGenerator, operation);
        }

        public static SwitchOperationStatus InitializeSwitchOperationStatus(SequenceGenerator sequenceGenerator, SwitchOperation operation)
        {
            return new SwitchOperationStatus(sequenceGenerator, operation);
        }

        public static AdviceSwitch InitializeAdviceSwitch()
        {
            return new AdviceSwitch();
        }
    }
}