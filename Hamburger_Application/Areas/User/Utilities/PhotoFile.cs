namespace Hamburger_Application.Areas.User.Utilities
{
	internal static class PhotoFile
	{
		//for controller
		internal static string GenerateUniqueFileName(IFormFile file)
		{
			if (file is not null)
			{
				Guid guid = Guid.NewGuid();
				string newFileName = guid.ToString() + "_" + file.FileName;
				return newFileName;
			}
			return null;
		}
		//for Validations 
		internal static bool BeValidImageFormat(IFormFile photo)
		{
			if (photo is null)                 // photo null => true;
				return true;



			var validFormats = new[] { ".jpg", ".jpeg", ".png" };
			var fileExtension = Path.GetExtension(photo.FileName);    //return jpg, jpeg, png



			return validFormats.Contains(fileExtension.ToLower());
		}
	}
}
