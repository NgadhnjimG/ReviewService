using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class DoctorReviewDataObject
{
	public int DoctorId { get; set; }
	public double StarReview { get; set; }
	public List<string> Comments { get; set; } = new List<string>();

	public DoctorReviewDataObject()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
