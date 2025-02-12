// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Trigger runs. </summary>
    public partial class FactoryTriggerRun
    {
        /// <summary> Initializes a new instance of FactoryTriggerRun. </summary>
        internal FactoryTriggerRun()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
            TriggeredPipelines = new ChangeTrackingDictionary<string, string>();
            RunDimension = new ChangeTrackingDictionary<string, string>();
            DependencyStatus = new ChangeTrackingDictionary<string, BinaryData>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of FactoryTriggerRun. </summary>
        /// <param name="triggerRunId"> Trigger run id. </param>
        /// <param name="triggerName"> Trigger name. </param>
        /// <param name="triggerType"> Trigger type. </param>
        /// <param name="triggerRunTimestamp"> Trigger run start time. </param>
        /// <param name="status"> Trigger run status. </param>
        /// <param name="message"> Trigger error message. </param>
        /// <param name="properties"> List of property name and value related to trigger run. Name, value pair depends on type of trigger. </param>
        /// <param name="triggeredPipelines"> List of pipeline name and run Id triggered by the trigger run. </param>
        /// <param name="runDimension"> Run dimension for which trigger was fired. </param>
        /// <param name="dependencyStatus"> Status of the upstream pipelines. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal FactoryTriggerRun(string triggerRunId, string triggerName, string triggerType, DateTimeOffset? triggerRunTimestamp, FactoryTriggerRunStatus? status, string message, IReadOnlyDictionary<string, string> properties, IReadOnlyDictionary<string, string> triggeredPipelines, IReadOnlyDictionary<string, string> runDimension, IReadOnlyDictionary<string, BinaryData> dependencyStatus, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            TriggerRunId = triggerRunId;
            TriggerName = triggerName;
            TriggerType = triggerType;
            TriggerRunTimestamp = triggerRunTimestamp;
            Status = status;
            Message = message;
            Properties = properties;
            TriggeredPipelines = triggeredPipelines;
            RunDimension = runDimension;
            DependencyStatus = dependencyStatus;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Trigger run id. </summary>
        public string TriggerRunId { get; }
        /// <summary> Trigger name. </summary>
        public string TriggerName { get; }
        /// <summary> Trigger type. </summary>
        public string TriggerType { get; }
        /// <summary> Trigger run start time. </summary>
        public DateTimeOffset? TriggerRunTimestamp { get; }
        /// <summary> Trigger run status. </summary>
        public FactoryTriggerRunStatus? Status { get; }
        /// <summary> Trigger error message. </summary>
        public string Message { get; }
        /// <summary> List of property name and value related to trigger run. Name, value pair depends on type of trigger. </summary>
        public IReadOnlyDictionary<string, string> Properties { get; }
        /// <summary> List of pipeline name and run Id triggered by the trigger run. </summary>
        public IReadOnlyDictionary<string, string> TriggeredPipelines { get; }
        /// <summary> Run dimension for which trigger was fired. </summary>
        public IReadOnlyDictionary<string, string> RunDimension { get; }
        /// <summary> Status of the upstream pipelines. </summary>
        public IReadOnlyDictionary<string, BinaryData> DependencyStatus { get; }
        /// <summary> Additional Properties. </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
