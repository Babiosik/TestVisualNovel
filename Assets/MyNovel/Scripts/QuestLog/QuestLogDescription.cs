using Naninovel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.MyNovel.Scripts.QuestLog
{
    public class QuestLogDescription : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textMeshPro;
        private QuestLogService _questLogService;

        private void Awake()
        {
            _questLogService = Engine.GetService<QuestLogService>();
            _textMeshPro.text = _questLogService.LastQuestLog;
        }

        private void OnEnable() =>
            _questLogService.QuestLogUpdated += OnLogUpdated;

        private void OnDisable() =>
            _questLogService.QuestLogUpdated -= OnLogUpdated;

        private void OnLogUpdated(string description)
        {
            _textMeshPro.text = description;
            _textMeshPro.ForceMeshUpdate(true);
            LayoutRebuilder.MarkLayoutForRebuild(transform.parent as RectTransform);
        }
    }
}