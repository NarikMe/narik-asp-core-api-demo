using Narik.Common.Shared.Interfaces;


namespace NarikDemo.Modules.Demo._CustomEntity
{
    public partial class CustomEntityViewModel : INarikViewModel
    {
        public long ViewModelId { get => Id; set => Id = (int)value; }
        
		
        public int Id { get; set; } 
        
		
        public string LName { get; set; } 
        
		
        public string FName { get; set; } 
        
    }
}
