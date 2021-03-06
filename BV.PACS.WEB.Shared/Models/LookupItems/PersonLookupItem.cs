﻿namespace BV.PACS.WEB.Shared.Models
{
    public class PersonLookupItem
    {
        [GetColumn("idfEmployee")]
        public string Id { get; set; }

        [GetColumn("FullName")]
        public string FullName { get; set; }

        [GetColumn("Organization")]
        public string Organization { get; set; }

        [GetColumn("Position")]
        public int Position { get; set; }

        [GetColumn("strFirstName")]
        public int FirstName { get; set; }

        [GetColumn("strFamilyName")]
        public int FamilyName { get; set; }

        [GetColumn("strSecondName")]
        public int SecondName { get; set; }


        public override string ToString()
        {
            return $"{FullName} ({Id})";
        }
    }
}