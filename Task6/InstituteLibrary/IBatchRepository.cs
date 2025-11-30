namespace InstituteLibrary;

public interface IBatchRepository
{
    void AddBatch(Batch batch1);
    void UpdateBatch(int BatchCode, Batch batch2);
    void DeleteBatch(int BatchCode);
    List<Batch> GetAllBatches();
    Batch GetBatch(int BatchCode);
    Batch GetBatchByCourse(int CourseCode);

}
