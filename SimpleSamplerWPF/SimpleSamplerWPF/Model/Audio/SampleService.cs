﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleSamplerWPF.Logic;

namespace SimpleSamplerWPF.Model.Audio
{
    public class SampleService : ISampleService
    {
        public void AddSample(CachedSound sound, Action<bool, Exception> callback)
        {
            throw new NotImplementedException();
        }

        public void GetSamples(Action<ObservableCollection<CachedSound>, Exception> callback)
        {
            throw new NotImplementedException();
        }

        public void RemoveSample(CachedSound sound, Action<bool, Exception> callback)
        {
            throw new NotImplementedException();
        }
    }
}
