﻿using Flexi.Application.Web.Subjects;

namespace Flexi.Application.Web.Endpoints.SubjectEndpoints;

public class SubjectListResponse
{
  public List<SubjectRecord> Subjects { get; set; } = new();
}
