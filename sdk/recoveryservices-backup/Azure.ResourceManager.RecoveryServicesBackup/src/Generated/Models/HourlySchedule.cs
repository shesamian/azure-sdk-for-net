// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The HourlySchedule. </summary>
    public partial class HourlySchedule
    {
        /// <summary> Initializes a new instance of HourlySchedule. </summary>
        public HourlySchedule()
        {
        }

        /// <summary> Initializes a new instance of HourlySchedule. </summary>
        /// <param name="interval">
        /// Interval at which backup needs to be triggered. For hourly the value
        ///  can be 4/6/8/12
        /// </param>
        /// <param name="scheduleWindowStartOn"> To specify start time of the backup window. </param>
        /// <param name="scheduleWindowDuration"> To specify duration of the backup window. </param>
        internal HourlySchedule(int? interval, DateTimeOffset? scheduleWindowStartOn, int? scheduleWindowDuration)
        {
            Interval = interval;
            ScheduleWindowStartOn = scheduleWindowStartOn;
            ScheduleWindowDuration = scheduleWindowDuration;
        }

        /// <summary>
        /// Interval at which backup needs to be triggered. For hourly the value
        ///  can be 4/6/8/12
        /// </summary>
        public int? Interval { get; set; }
        /// <summary> To specify start time of the backup window. </summary>
        public DateTimeOffset? ScheduleWindowStartOn { get; set; }
        /// <summary> To specify duration of the backup window. </summary>
        public int? ScheduleWindowDuration { get; set; }
    }
}
