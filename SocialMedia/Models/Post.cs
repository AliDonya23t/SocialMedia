﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SocialMedia.Models;

public partial class Post
{
    public string Id { get; set; }

    public string MediaLink { get; set; }

    public string Caption { get; set; }

    public bool Is_Active { get; set; }

    public string PageId { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Page Page { get; set; }
}