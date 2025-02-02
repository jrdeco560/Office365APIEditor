﻿// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information. 

using System.Collections.Generic;

namespace Office365APIEditor.ViewerHelper.Data.CalendarAPI
{
    class Event : OutlookRestApiBaseObject
    {
        private string createdDateTime;
        private IList<Attendee> attendees;
        private Data.DateTimeOffset end;
        private bool? isAllDay;
        private Recipient organizer;
        private Data.DateTimeOffset start;
        private string subject;

        protected Event()
        {
        }

        public Event(string JsonData) : base(JsonData)
        {
        }

        public IList<Attendee> Attendees
        {
            get
            {
                if (attendees == null)
                {
                    attendees = LoadPropertyFromRawJson("attendees", new List<Attendee>());
                }

                return attendees;
            }

            set => attendees = value;
        }

        public string CreatedDateTime
        {
            get
            {
                if (createdDateTime == null)
                {
                    createdDateTime = LoadPropertyFromRawJson<string>("createdDateTime", null);
                }

                return createdDateTime;
            }

            set => createdDateTime = value;
        }

        public Data.DateTimeOffset End
        {
            get
            {
                if (end == null)
                {
                    end = LoadPropertyFromRawJson("end", new Data.DateTimeOffset());
                }

                return end;
            }

            set => end = value;
        }

        public bool? IsAllDay
        {
            get
            {
                if (isAllDay == null)
                {
                    isAllDay = LoadPropertyFromRawJson("isAllDay", new bool?());
                }

                return isAllDay;
            }

            set => isAllDay = value;
        }

        public Recipient Organizer
        {
            get
            {
                if (organizer == null)
                {
                    organizer = LoadPropertyFromRawJson<Recipient>("organizer", null);
                }

                return organizer;
            }

            set => organizer = value;
        }

        public Data.DateTimeOffset Start
        {
            get
            {
                if (start == null)
                {
                    start = LoadPropertyFromRawJson("start", new Data.DateTimeOffset());
                }

                return start;
            }

            set => start = value;
        }

        public string Subject
        {
            get
            {
                if (subject == null)
                {
                    subject = LoadPropertyFromRawJson<string>("subject", null);
                }

                return subject;
            }

            set => subject = value;
        }
    }
}