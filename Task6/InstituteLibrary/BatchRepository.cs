namespace InstituteLibrary;

public class BatchRepository : IBatchRepository
{
    List<Batch> batch = new List<Batch>();
    public void AddBatch(Batch batch1)
    {
        batch.Add(batch1);
    }

    public void DeleteBatch(int BatchCode)
    {
        Batch new1 = GetBatch(BatchCode);
        batch.Remove(new1);
    }

    public List<Batch> GetAllBatches()
    {
        return batch;
    }

    public Batch GetBatch(int BatchCode)
    {
        Batch batch2 = null;
        foreach (Batch batch1 in batch)
        {
            if (batch1.BatchCode == BatchCode)
            {
                batch2 = batch1;
                break;
            }
        }
        return batch2;
    }

    public Batch GetBatchByCourse(int CourseCode)
    {
        Batch courcode = null;
        foreach (Batch new2 in batch)
        {
            if (new2.CourseCode == CourseCode)
            {
                courcode = new2;
                break;
            }
        }
        return courcode;
    }

    public void UpdateBatch(int BatchCode, Batch batch2)
    {
        Batch new3 = GetBatch(BatchCode);
        if (BatchCode != null)
        {
            new3.CourseCode = batch2.BatchCode;
            new3.EndDate = batch2.EndDate;
            new3.StartDate = batch2.StartDate;
        }
    }
}
