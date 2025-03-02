﻿using Serenity.ComponentModel;

namespace AdminPanel.Conne.Forms;

[FormScript("Conne.Review")]
[BasedOnRow(typeof(ReviewRow), CheckNames = true)]
public class ReviewForm
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
}