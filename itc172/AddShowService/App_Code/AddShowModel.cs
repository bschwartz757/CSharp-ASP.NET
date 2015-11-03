﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Artist
{
    public Artist()
    {
        this.ShowDetails = new HashSet<ShowDetail>();
    }

    public int ArtistKey { get; set; }
    public string ArtistName { get; set; }
    public string ArtistEmail { get; set; }
    public string ArtistWebPage { get; set; }
    public Nullable<System.DateTime> ArtistDateEntered { get; set; }

    public virtual ICollection<ShowDetail> ShowDetails { get; set; }
}

public partial class Show
{
    public Show()
    {
        this.ShowDetails = new HashSet<ShowDetail>();
    }

    public int ShowKey { get; set; }
    public string ShowName { get; set; }
    public Nullable<int> VenueKey { get; set; }
    public System.DateTime ShowDate { get; set; }
    public System.TimeSpan ShowTime { get; set; }
    public string ShowTicketInfo { get; set; }
    public Nullable<System.DateTime> ShowDateEntered { get; set; }

    public virtual ICollection<ShowDetail> ShowDetails { get; set; }
}

public partial class ShowDetail
{
    public int ShowDetailKey { get; set; }
    public Nullable<int> ShowKey { get; set; }
    public Nullable<int> ArtistKey { get; set; }
    public System.TimeSpan ShowDetailArtistStartTime { get; set; }
    public string ShowDetailAdditional { get; set; }

    public virtual Artist Artist { get; set; }
    public virtual Show Show { get; set; }
}