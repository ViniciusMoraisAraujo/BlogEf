﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEf.Models;

[Table("Post")]
public class Post
{
    [Key]//Primary Key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }
    public Category Category { get; set; } //navigation properties
    [ForeignKey("AuthorId")]
    public int AuthorId { get; set; }
    public User Author { get; set; } //navigation properties 
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Body { get; set; }
    public string Slug { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    
    
}