CREATE PROCEDURE GetLatestMessagesForRecipient
    @RecipientID INT
AS
BEGIN
    SET NOCOUNT ON;

    WITH RankedMessages AS (
        SELECT 
            *,
            ROW_NUMBER() OVER (
                PARTITION BY SenderID 
                ORDER BY DateSent DESC
            ) AS RowNum
        FROM Messages
        WHERE RecipientID = @RecipientID
    )
    SELECT *
    FROM RankedMessages
    WHERE RowNum = 1
    ORDER BY DateSent DESC;
END;
