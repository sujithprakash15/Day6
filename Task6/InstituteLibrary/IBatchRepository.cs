namespace InstituteLibrary;

public interface IBatchRepository
{
    void AddBatch(Batch batch1);
    Task UpdateBatch(int BatchCode, Batch batch2);
    Task DeleteBatch(int BatchCode);
    List<Batch> GetAllBatches();
    Task<Batch> GetBatch(int BatchCode);
    Task<Batch> GetBatchByCourse(int CourseCode);

}
