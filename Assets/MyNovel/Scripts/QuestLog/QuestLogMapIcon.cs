using Naninovel;
using UnityEngine;

namespace Assets.MyNovel.Scripts.QuestLog
{
    public class QuestLogMapIcon : MonoBehaviour
    {
        [SerializeField] private GameObject _questIcon;
        [SerializeField] private string _locationName;
        private QuestLogService _questLogService;

        private void Awake()
        {
            _questLogService = Engine.GetService<QuestLogService>();
            OnLogUpdated(_questLogService.LastQuestLog);
        }

        private void OnEnable() =>
            _questLogService.QuestLogUpdated += OnLogUpdated;

        private void OnDisable() =>
            _questLogService.QuestLogUpdated -= OnLogUpdated;

        private void OnLogUpdated(QuestLogData data)
        {
            if (data == null || string.IsNullOrEmpty(data.Location))
                return;

            bool isQuestHere = data.Location.Equals(_locationName);
            _questIcon.SetActive(isQuestHere);
        }
    }
}