using Microsoft.AspNetCore.Mvc;

public class Asset {
	public Guid Id { get; set; } = Guid.NewGuid();

	public string? Name { get; set; }
	
}