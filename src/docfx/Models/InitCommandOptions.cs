// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DocAsCode
{
    using CommandLine;

    [OptionUsage("init")]
    internal class InitCommandOptions : ICanPrintHelpMessage
    {
        [Option('h', "help", HelpText = "Print help message for this sub-command")]
        public bool PrintHelpMessage { get; set; }

        [Option('q', "quiet", HelpText = "Quietly generate the default docfx.json")]
        public bool Quiet { get; set; }

        [Option('o', "output", HelpText = "Specify the output folder of the config file. If not specified, the config file will be saved to a new folder docfx_project", DefaultValue = "docfx_project")]
        public string OutputFolder { get; set; }
    }
}
