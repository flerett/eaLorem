var splitLines = linesCollection
    .Where(line => !string.IsNullOrEmpty(line)) // Exclude null or empty lines
    .SelectMany(line => line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
    .ToList(); // Flatten the arrays into a single list and remove empty entries
