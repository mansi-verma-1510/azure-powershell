// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>The recurrence schedule occurrence.</summary>
    public partial class RecurrenceScheduleOccurrence :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRecurrenceScheduleOccurrence,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRecurrenceScheduleOccurrenceInternal
    {

        /// <summary>Backing field for <see cref="Day" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DayOfWeek? _day;

        /// <summary>The day of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DayOfWeek? Day { get => this._day; set => this._day = value; }

        /// <summary>Backing field for <see cref="Occurrence" /> property.</summary>
        private int? _occurrence;

        /// <summary>The occurrence.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public int? Occurrence { get => this._occurrence; set => this._occurrence = value; }

        /// <summary>Creates an new <see cref="RecurrenceScheduleOccurrence" /> instance.</summary>
        public RecurrenceScheduleOccurrence()
        {

        }
    }
    /// The recurrence schedule occurrence.
    public partial interface IRecurrenceScheduleOccurrence :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>The day of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The day of the week.",
        SerializedName = @"day",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DayOfWeek) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DayOfWeek? Day { get; set; }
        /// <summary>The occurrence.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The occurrence.",
        SerializedName = @"occurrence",
        PossibleTypes = new [] { typeof(int) })]
        int? Occurrence { get; set; }

    }
    /// The recurrence schedule occurrence.
    internal partial interface IRecurrenceScheduleOccurrenceInternal

    {
        /// <summary>The day of the week.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.DayOfWeek? Day { get; set; }
        /// <summary>The occurrence.</summary>
        int? Occurrence { get; set; }

    }
}