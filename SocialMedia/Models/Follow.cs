﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SocialMedia.Models;

public partial class Follow
{
    public int id { get; set; }

    public int PageId { get; set; }

    public int Followingld { get; set; }

    public virtual Page FollowingldNavigation { get; set; }

    public virtual Page Page { get; set; }
}