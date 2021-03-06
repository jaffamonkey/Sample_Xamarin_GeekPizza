﻿using System;
using System.Configuration;
using System.Linq;
using GeekPizza.Specs.Drivers;
using TechTalk.SpecFlow;

namespace GeekPizza.Specs.Support
{
    [Binding]
    public class DynamicDriverSelector : Steps
    {
        [BeforeScenario(Order = -100)]
        public void Init()
        {
            switch (ConfigurationManager.AppSettings["AUTOMODE"])
            {
                case "Android":
                    ScenarioContext.ScenarioContainer.RegisterTypeAs<AndroidUiAppDriver, IAppDriver>();
                    break;
                case "iOS":
                    ScenarioContext.ScenarioContainer.RegisterTypeAs<iOSUiAppDriver, IAppDriver>();
                    break;
                default:
                    ScenarioContext.ScenarioContainer.RegisterTypeAs<ViewModelAppDriver, IAppDriver>();
                    break;
            }
        }
    }
}
