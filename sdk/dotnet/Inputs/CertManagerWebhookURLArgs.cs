// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.ChartCertManager.Inputs
{

    public sealed class CertManagerWebhookURLArgs : Pulumi.ResourceArgs
    {
        [Input("host")]
        public Input<string>? Host { get; set; }

        public CertManagerWebhookURLArgs()
        {
        }
    }
}