using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Courses;
using CMS.Core.Domain.Lessons;
using CMS.Core.Domain.Topics;
using CMS.Data.EFCore;
using CMS.Service.CourseServices;
using CMS.Service.LessonServices;
using CMS.Service.TopicSerivces;
using Xunit;
using CMS.Util.PermissionUtils;
using Domain.Permissions;
using Domain.Roles;

namespace UnitTest
{
    public class TestRepository
    {
        private readonly ITopicService _topicService;
        private readonly ICourseService _courseService;
        private readonly ILessonService _lessonService;

        public TestRepository()
        {
            _topicService = new TopicSerivce();
            _courseService = new CourseService();
            _lessonService = new LessonService();
        }

        [Fact]
        public void TestInsertRow()
        {
            // Given
            Topic topic = new Topic
            {
                Title = "C#",
                Description = "C# là ngôn ngữ lập trình bậc cao",
                Body = "<p>Hello C#</p>",
                Url = "topic-c-sharp",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
            };
            _topicService.Insert(topic);
            _topicService.Save();

            Course course = new Course
            {
                Title = "Course 1: C# History",
                Url = "khoa-hoc-lich-su-c-sha2222rp",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
            };
            topic.Courses.Add(course);

            Course course1 = new Course
            {
                Title = "Course 2: C# Programming",
                Url = "khoa-hocưd-lich-su-c-sharp",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
            };
            topic.Courses.Add(course1);
            Course course2 = new Course
            {
                Title = "Course 3: C# Mechanics",
                Url = "khoa-hoc-lich-su-c-sha33333rp",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
            };
            topic.Courses.Add(course2);



            _topicService.Save();

            var courseEntity = _courseService.GetEntity(s => s.Url == "khoa-hoc-lich-su-c-sha2222rp");
            if (courseEntity != null)
            {
                var lesson = new Lesson
                {
                    Title = "Bài học c# đầu tiên",
                    Body = "<p>C# là ....... </p",
                    Description = "Mô Tả C#",
                    Url = "bai-hoc-c-sharp-dau-tien",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                };

                courseEntity.Lessons.Add(lesson);
                _courseService.Save();
            }


            var courseEntity1 = _courseService.GetEntity(s => s.Url == "khoa-hocưd-lich-su-c-sharp");
            if (courseEntity != null)
            {
                var lesson = new Lesson
                {
                    Title = "Bài học c# đầu tiên",
                    Body = "<p>C# là ....... </p",
                    Description = "Mô Tả C#",
                    Url = "bai-hoc-c-sharp-dau-tien",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                };

                courseEntity.Lessons.Add(lesson);
                _courseService.Save();
            }


            var courseEntity2 = _courseService.GetEntity(s => s.Url == "khoa-hoc-lich-su-c-sha33333rp");
            if (courseEntity != null)
            {

                for (int i = 0; i < 3; i++)
                {
                    var lesson = new Lesson
                    {
                        Title = $"Bài học c# {i + 1}",
                        Body = "<p>C# là ....... </p",
                        Description = "Mô Tả C#",
                        Url = "bai-hoc-c-sharp-dau-tien",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Now,
                    };
                    courseEntity.Lessons.Add(lesson);
                }
                _courseService.Save();
            }


            // When

            // Then
        }

        [Fact]
        public void TestUpdateRow()
        {
            var topic = _topicService.GetById(2);
            topic.Title = "SQL";
            _topicService.Save();
        }

        [Fact]
        public void TestReadRow()
        {
            var topic = _topicService.GetTable.Include(s => s.Courses);
        }

        [Fact]
        public void Test_GeneratePermissionViewModel_Success()
        {
            List<PermissionViewModel> lstPermissionModel = PermissionUtil.GeneratePermissionViewModel();
            foreach (var item in lstPermissionModel)
            {
                Console.WriteLine($"Group {item.GroupPermission}");
                foreach (var role in item.RoleClaims)
                {
                    Console.WriteLine($"Claim Name {role.Name}");
                    Console.WriteLine($"Claim Value {role.Value}");
                }
            }

        }
    }
}