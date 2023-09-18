﻿using Taxify.Domain.Commons;

namespace Taxify.Domain.Entities;

public class Message : Auditable
{
    public string Content { get; set; }
    public long FromId { get; set; }
    public long ToId { get; set; }
    public long AttachmentId { get; set; }
    public Attachment Attachment { get; set; }
}
