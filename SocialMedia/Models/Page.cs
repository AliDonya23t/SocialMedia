﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SocialMedia.Models;

public partial class Page
{
    public string Id { get; set; }

    public string UserId { get; set; }

    public bool Is_Active { get; set; }

    public virtual ICollection<Follow> FollowFollowings { get; set; } = new List<Follow>();

    public virtual ICollection<Follow> FollowPages { get; set; } = new List<Follow>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual User User { get; set; }
}