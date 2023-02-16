﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authzed.Api.V1;
using SpiceDb.Enum;

namespace SpiceDb.Models;

public class ResolvedSubject
{
	public string Id { get; set; } = string.Empty;
	public Permissionship Permissionship { get; set; } = Permissionship.Unspecified;
	public List<string> MissingRequiredContext = new();
}

public class LookupSubjectsResponse
{
	public ZedToken? LookedUpAt { get; set; }
	public ResolvedSubject Subject { get; set; } = new();
	public List<ResolvedSubject> ExcludedSubjects { get; set; } = new();
}
