// ----------------------------------------------------
// <copyright file="TodoItem.cs" company="NATK">
// Copyright (c) NATK. All rights reserved.
// </copyright>
// ----------------------------------------------------

namespace Todo.Core
{
    using System;

    public class TodoItem
    {
        public TodoItem(string title)
        {
            this.Title = title?.Trim() ?? throw new ArgumentNullException(nameof(title));
        }

        public Guid Id { get; } = Guid.NewGuid();

        public string Title { get; private set; }

        public bool IsDone { get; private set; }

        public void MarkDone()
        {
            this.IsDone = true;
        }

        public void MarkUndone()
        {
            this.IsDone = false;
        }

        public void Rename(string newTitle)
        {
            if (string.IsNullOrWhiteSpace(newTitle))
            {
                throw new ArgumentException("Title is required", nameof(newTitle));
            }

            this.Title = newTitle.Trim();
        }
    }
}
