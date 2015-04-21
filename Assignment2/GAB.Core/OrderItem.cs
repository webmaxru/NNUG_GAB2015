﻿namespace GAB.Core
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public class OrderItem
    {
        [DataMember(Name = "no")]
        public int No { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        public OrderItem()
        {
            No = 0;

            Name = string.Empty;
        }

        public override string ToString()
        {
            return string.Format("No: {0}, Name: {1}", No, Name);
        }
    }
}